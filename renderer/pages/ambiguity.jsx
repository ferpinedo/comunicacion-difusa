import Layout from "../components/Layout";
import { useState, useEffect } from "react";
import BackButton from "../components/BackButton";
import SpeakButton from "../components/SpeakButton";
import NextIcon from "../public/icons/next.svg";
import BackIcon from "../public/icons/back.svg";
import { observer, inject } from "mobx-react";
import WORDS from "../resources/words";
import { shuffleWords, shuffle } from "../utils/shuffle";
import AmbiguityTest from "../components/AmbiguityTest";

const Ambiguity = ({ store }) => {
  const [currentWord, setCurrentWord] = useState(0);
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);
  const [startTime, setStartTime] = useState(new Date());
  const [words, setWords] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  useEffect(() => {
    const perform = async () => {
      let words = WORDS[store.results.level];
      await shuffle(words);
      setWords(words);
      setIsLoading(false);
      return null;
    };
    perform();
  }, []);

  if (isLoading) {
    return <div>Cargando</div>;
  }

  const thisWords = words[currentWord];
  const thisVariation = thisWords[currentVariation];

  const next = () => {
    if (currentVariation < thisWords.length) {
      setCurrentVariation(currentVariation + 1);
    } else {
      setCurrentVariation(0);
      const nextWord = currentWord + 1;
      if (nextWord < words.length) {
        setCurrentWord(nextWord);
      } else {
        setShowTest(true);
        store.results.exerciseTime = (new Date().getTime() - startTime) / 1000;
        setStartTime(new Date());
      }
    }
  };

  const back = () => {
    if (currentVariation > 0) {
      setCurrentVariation(currentVariation - 1);
    } else {
      if (currentWord > 0) {
        const prevWord = words[currentWord - 1];
        setCurrentWord(currentWord - 1);
        setCurrentVariation(prevWord.length - 1);
      }
    }
  };

  const isSideBySide = currentVariation >= thisWords.length;

  let content = (
    <>
      <div className="w-full h-full flex flex-col justify-center items-center space-y-10">
        {!isSideBySide ? (
          <>
            <h2>{thisVariation.name}</h2>
            <div className="flex w-11/12 justify-center space-between">
              {thisVariation.imagesPaths.map((path) => (
                <img
                  className="w-1/3 h-64 object-cover"
                  src={"images/exercises/" + path}
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
                key={variation.imagesPaths[0]}
                className="flex items-center flex-col space-y-2 w-1/2 px-2"
              >
                <h2>{variation.name}</h2>
                <SpeakButton text={variation.meaning} raw>
                  <img
                    className="w-full h-64 border-dashed border-2 border-gray-700 border-solid rounded-lg p-2 m-2 object-cover"
                    src={"images/exercises/" + variation.imagesPaths[0]}
                    alt=""
                  />
                </SpeakButton>
              </div>
            ))}
          </div>
        )}

        <div className="flex space-x-5">
          {!(currentVariation === 0 && currentWord === 0) && (
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
    </>
  );
  if (showTest) {
    content = <AmbiguityTest levelWords={words} />;
  }
  return (
    <Layout>
      <span className="text-left ml-10 my-5 p-1 rounded-lg bg-gray-300">
        {"Ambiguedad > Nivel " + store.results.level}
      </span>
      {content}
      <BackButton route="/categories" type="menu" />
    </Layout>
  );
};

export default inject("store")(observer(Ambiguity));
