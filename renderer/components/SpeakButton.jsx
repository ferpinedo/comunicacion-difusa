import { useEffect, useState } from "react";
import speak from "../utils/textToSpeech";
import AudioIcon from "../public/icons/audio.svg";

const SpeakButton = ({ text, raw, children }) => {
  // const [voices, setVoices] = useState([]);
  const [message, setMessage] = useState(null);

  useEffect(() => {
    let voices;
    const voicesUpdate = () => {
      const gottenVoices = speechSynthesis.getVoices();
      let newVoices = gottenVoices.filter((voice) =>
        voice.lang.includes("es-MX")
      );
      if (newVoices.length === 0) {
        newVoices = gottenVoices.filter((voice) => voice.lang.includes("es"));
        if (newVoices.length === 0) {
          newVoices = gottenVoices;
        }
      }
      voices = newVoices;
    };
    voicesUpdate();
    if (speechSynthesis.onvoiceschanged !== undefined) {
      speechSynthesis.onvoiceschanged = voicesUpdate;
    }
    const newMessage = new SpeechSynthesisUtterance(text);
    newMessage.voice = voices[localStorage.getItem("voice")];
    newMessage.volume = localStorage.getItem("volume");
    newMessage.pitch = localStorage.getItem("pitch");
    newMessage.rate = localStorage.getItem("rate");
    setMessage(newMessage);

    if (!raw) {
      speechSynthesis.speak(newMessage);
    }
    return () => {
      speechSynthesis.cancel();
    };
  }, []);

  const width = raw ? "30px" : "40px";
  const fill = raw ? "gray" : "#B49ACA";
  return (
    <div
      className={
        "cursor-pointer flex flex-col items-center justify-center " +
        (!raw && " p-5 fixed bottom-0 right-0")
      }
      onClick={() => speechSynthesis.speak(message)}
    >
      {children}
      <AudioIcon width={width} fill={fill} />
    </div>
  );
};

export default SpeakButton;
