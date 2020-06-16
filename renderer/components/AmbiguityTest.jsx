import { observer, inject } from "mobx-react";
import { useState, useEffect } from "react";
import { shuffle } from "../utils/shuffle";
import NextIcon from "../public/icons/next.svg";
import SpeakButton from "./SpeakButton";
import Link from "next/link";

const AmbiguityTest = ({ store, levelWords }) => {
  const [trys, setTrys] = useState(0);
  const [isRunning, setIsRunning] = useState(false);
  const [startTime, setStartTime] = useState(null);
  const [words, setWords] = useState([]);
  const [currentWord, setCurrentWord] = useState([]);
  const [average, setAverage] = useState(null);

  useEffect(() => {
    let newWords = [];
    console.log(levelWords);
    levelWords.forEach((wordsGroup) => {
      wordsGroup.forEach((variation) => {
        variation.done = false;
        newWords.push(variation);
      });
    });
    newWords = shuffle(newWords);
    setWords(newWords);
    setCurrentWord(newWords[Math.floor(Math.random() * newWords.length)]);
  }, []);

  const isCorrect = (word) => {
    const newWords = [...words];
    if (currentWord.meaning === word.meaning) {
      newWords[words.indexOf(currentWord)].done = true;
      setWords(newWords);
    }
    setTrys(trys + 1);

    const availableWords = newWords.filter((element) => !element.done);

    if (availableWords.length === 0) {
      console.log("terminado");
      let results = JSON.parse(localStorage.getItem("results"));
      if (!results) {
        results = [];
      }
      results.push({
        ...store.results,
        testTime: (startTime - new Date().getTime()) / 1000,
        correct: words.length,
        trys,
      });
      setAverage((words.length / trys) * 100);
      return;
    }
    setCurrentWord(
      availableWords[Math.floor(Math.random() * availableWords.length)]
    );
    console.log("new current word");
    console.log(
      availableWords[Math.floor(Math.random() * availableWords.length)]
    );
  };

  if (average) {
    const text =
      average > 70
        ? "Felicidades tu calificación es aprobatoria. Puedes avanzar al siguiente nivel"
        : "Lo sentimos, tienes que volver a realizar este ejercicio.";
    return (
      <div className="flex flex-col items-center justify-center">
        <h2>Evaluación terminada</h2>
        {average > 70 && <span style={{ fontSize: "40px" }}>🎊 🎉 🎊</span>}
        <Link href="/levels">
          <div className="cursor-pointer">
            <NextIcon width="40px" height="40px" fill="#5C9DC1" />
          </div>
        </Link>
        <SpeakButton text={text} />
      </div>
    );
  }

  if (!isRunning) {
    return (
      <div className="flex flex-col items-center justify-center">
        <h2>Evaluación</h2>
        <div
          onClick={() => {
            setIsRunning(true);
            setStartTime(new Date());
          }}
          className="cursor-pointer"
        >
          <NextIcon width="40px" height="40px" fill="#5C9DC1" />
        </div>
        <SpeakButton text="A continuación comenzará la prueba. ¡Las instrucciones son muy sencillas! Deberás de presionar la imagen correspondiente a la oración dicha." />
      </div>
    );
  }

  console.log(currentWord.meaning);
  return (
    <div className="grid grid-cols-5">
      {words.map((word) => (
        <img
          className={
            "w-full h-64 object-cover p-2 cursor-pointer " +
            (word.done && "opacity-0")
          }
          src={"/images/exercises/" + word.imagesPaths[0]}
          alt=""
          key={word.imagesPaths[0]}
          onClick={() => isCorrect(word)}
        />
      ))}
      <SpeakButton text={currentWord.meaning} />
    </div>
  );
};

export default inject("store")(observer(AmbiguityTest));
