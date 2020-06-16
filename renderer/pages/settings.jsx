import { inject, observer } from "mobx-react";
import { useState, useEffect } from "react";
import Layout from "../components/Layout";
import BackButton from "../components/BackButton";

const Settings = ({ store }) => {
  const [voice, setVoice] = useState(0);
  const [voices, setVoices] = useState([]);
  const [volume, setVolume] = useState(1);
  const [pitch, setPitch] = useState(1);
  const [rate, setRate] = useState(1);

  useEffect(() => {
    let newVoices = speechSynthesis.getVoices();
    newVoices = newVoices.filter((voice) => voice.lang.includes("es"));
    console.log(newVoices);
    setVoices(newVoices);
  }, []);

  const onTest = () => {
    const message = new SpeechSynthesisUtterance(
      "Esta es una prueba de audio de la aplicación llamada Comunicación difusa."
    );
    message.voice = voices[voice];
    message.volume = volume;
    message.pitch = pitch;
    message.rate = rate;
    speechSynthesis.speak(message);
  };

  console.log(voice);
  const fieldClass =
    "flex space-x-2 mb-2 mx-4 items-center w-40 justify-between";

  return (
    <Layout>
      <div className="w-full h-full flex flex-col justify-center items-center">
        <h1>Ajustes</h1>
        <div className="flex space-x-8 px-8">
          <div className="w-1/2">
            <h3>Configuración</h3>
            <div className="flex flex-wrap">
              <div className={fieldClass}>
                <label htmlFor="voice">Voz</label>
                <select
                  name="voice"
                  id="voice"
                  value={voice}
                  onChange={(e) => setVoice(e.target.value)}
                >
                  {voices.map((voice) => (
                    <option key={voice.name} value={voices.indexOf(voice)}>
                      {voice.name} / {voice.lang}
                    </option>
                  ))}
                </select>
              </div>
              <div className={fieldClass}>
                <label htmlFor="volume">Volumen</label>
                <input
                  type="number"
                  className="w-16"
                  max={1}
                  min={0}
                  step={0.1}
                  id="volume"
                  value={volume}
                  onChange={(e) => setVolume(e.target.value)}
                />
              </div>

              <div className={fieldClass}>
                <label htmlFor="pitch">Tono</label>
                <input
                  type="number"
                  className="w-16"
                  max={1}
                  min={0}
                  step={0.1}
                  id="pitch"
                  value={pitch}
                  onChange={(e) => setPitch(e.target.value)}
                />
              </div>

              <div className={fieldClass}>
                <label htmlFor="rate">Velocidad</label>
                <input
                  type="number"
                  className="w-16"
                  max={1}
                  min={0}
                  step={0.1}
                  id="rate"
                  value={rate}
                  onChange={(e) => setRate(e.target.value)}
                />
              </div>
            </div>
            <button onClick={onTest}>Probar audio</button>

            <hr />
            <h3>Exportar resultados</h3>
            <p>
              Si lo deseas puedes exportar la información almacenada para la
              aplicación con el siguiente botón.
            </p>
            <button>Exportar</button>
          </div>
          <div className="w-1/2">
            <h3>Sobre la aplicación</h3>
            <p>
              Creada por Fernando Pinedo y Elías Sanchez bajo la supervición del
              Ing. Eduardo Contreras del Instituto Tecnológico de Saltillo
            </p>
            <p>
              Para más información enviar correo a{" "}
              <a href="mailto:fer@positive0.com" target="_blank">
                fer@positive0.com
              </a>
            </p>

            <hr />
            <h3>Recursos utilizados</h3>
            <ul>
              <li>
                <a href="https://pexels.com" target="_blank">
                  Pexels
                </a>
              </li>
              <li>
                <a href="https://unsplash.com" target="_blank">
                  Unsplash
                </a>
              </li>
              <li>
                <a href="https://flaticon.com" target="_blank">
                  FlatIcon
                </a>
              </li>
            </ul>
          </div>
        </div>
      </div>
      <BackButton route="/login" />
      <style jsx>{`
        h3 {
          font-size: 22px;
        }
        a {
          text-decoration: underline #5c9dc1;
        }
        hr {
          margin-bottom: 15px;
          margin-top: 15px;
        }
      `}</style>
    </Layout>
  );
};

export default inject("store")(observer(Settings));
