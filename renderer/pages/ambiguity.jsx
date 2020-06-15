import Layout from "../components/Layout";
import { useState, useEffect } from "react";
import BackButton from "../components/BackButton";
import SpeakButton from "../components/SpeakButton";
import NextIcon from "../public/icons/next.svg";
import { observer, inject } from "mobx-react";

const words = {
  1: [
    [
      {
        name: "Asia",
        imagesPaths: ["1.jpg"],
        meaning: "Asia. Asia es uno de los 5 continentes en el mundo.",
      },
      {
        name: "Hacia",
        imagesPaths: ["1.jpg", "2.jpg", "3.jpg"],
        meaning: "Hacia. Me dirijo hacia mi casa.",
      },
    ],
    [
      {
        name: "Botar",
        imagesPaths: ["1.jpg", "2.jpg", "3.jpg"],
        meaning: "Botar. El niño bota el balón de basquetbol.",
      },
      {
        name: "Votar",
        imagesPaths: ["1.jpg", "2.jpg", "3.jpg"],
        meaning:
          "Votar. Todos los ciudadanos tienen que votar para elegir a un nuevo presidente.",
      },
    ],
  ],
  2: [["Sierra1", "Sierra2"], ["Bello"], ["Arrollo", "Arroyo"]],
  3: [
    ["Aprehender", "Aprender"],
    ["Ato", "Hato"],
    ["Balsa", "Valsa"],
    ["Baya", "Vaya", "Valla"],
  ],
};

const Ambiguity = ({ store }) => {
  const [currentWord, setCurrentWord] = useState(0);
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);
  const [start, setStartTime] = useState(new Date());

  console.log(JSON.stringify(store.results));

  const next = () => {
    if (currentVariation < thisWords.length) {
      setCurrentVariation(currentVariation + 1);
    } else {
      setCurrentVariation(0);
      setCurrentWord(currentWord + 1);
    }
  };

  const back = () => {
    if (currentVariation > 0) {
      setCurrentVariation(currentVariation - 1);
    } else {
      if (currentWord > 0) {
        const prevWord = words[store.results.level + ""][currentWord - 1];
        setCurrentWord(prevWord);
        setCurrentVariation(prevWord[prevWord.length - 1]);
      }
    }
  };

  const thisWords = words[store.results.level + ""][currentWord];
  const thisVariation = thisWords[currentVariation];

  const isSideBySide = currentVariation >= thisWords.length;
  return (
    <Layout>
      <span className="text-left ml-10 my-5 p-1 rounded-lg bg-gray-300">
        {"Ambiguedad > Nivel 1"}
      </span>
      <div className="w-full h-full flex flex-col justify-center items-center space-y-10">
        {!isSideBySide ? (
          <>
            <h2>{thisVariation.name}</h2>
            <div className="flex w-11/12 justify-center space-between">
              {thisVariation.imagesPaths.map((path) => (
                <img
                  className="w-1/3 h-64 object-cover"
                  src={"/images/exercises/" + thisVariation.name + "/" + path}
                  alt=""
                  key={path}
                />
              ))}
            </div>
            <SpeakButton text={thisVariation.meaning} />
          </>
        ) : (
          <div className="flex justify-center space-x-5">
            {thisWords.map((variation) => (
              <div
                key={variation.name}
                className="flex items-center flex-col space-y-2 w-1/2 px-2"
              >
                <h2>{variation.name}</h2>
                <SpeakButton text={variation.meaning} raw>
                  <img
                    className="w-full h-64 border-dashed border-gray-700 border-solid rounded-lg p-5 object-cover"
                    src={
                      "/images/exercises/" +
                      variation.name +
                      "/" +
                      variation.imagesPaths[0]
                    }
                    alt=""
                  />
                </SpeakButton>
              </div>
            ))}
          </div>
        )}

        <div className="flex space-x-5">
          {currentVariation === 0 && currentWord === 0 && (
            <div onClick={back} className="cursor-pointer">
              <BackIcon width="40px" height="40px" fill="#5C9DC1" />
            </div>
          )}
          <div onClick={next} className="cursor-pointer">
            <NextIcon width="40px" height="40px" fill="#5C9DC1" />
          </div>
        </div>
      </div>
      {isSideBySide && (
        <SpeakButton text="Presiona las imágenes para escuchar su significado." />
      )}
      <BackButton route="/categories" type="menu" />
    </Layout>
  );
};

export default inject("store")(observer(Ambiguity));
