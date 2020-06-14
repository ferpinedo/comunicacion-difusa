import { Component, useEffect } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import { useState } from "react";
import BackButton from "../components/BackButton";
import SpeakButton from "../components/SpeakButton";

const words = {
  1: [
    ["Asia", "Hacia"],
    ["Botar", "Votar"],
  ],
  2: [["Sierra1", "Sierra2"], ["Bello"], ["Arrollo", "1"]],
  3: [
    ["Aprehender", "Aprender"],
    ["Ato", "Hato"],
    ["Balsa", "Valsa"],
    ["Baya", "Vaya", "Valla"],
  ],
};

const Ambiguity = () => {
  const [currentWord, setCurrentWord] = useState(0);
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);

  return (
    <Layout>
      <span className="text-left ml-10 my-5 p-1 rounded-lg bg-gray-300">
        {"Ambiguedad > Nivel 1"}
      </span>
      <div className="w-full h-full flex flex-col justify-center items-center space-y-10">
        {currentVariation < words["1"][currentWord].length ? (
          <>
            <h2>{words["1"][currentWord][currentVariation]}</h2>
            <div className="flex space-x-5 w-11/12 justify-center">
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words["1"][currentWord][currentVariation] +
                  "/2.jpg"
                }
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words["1"][currentWord][currentVariation] +
                  "/1.jpg"
                }
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words["1"][currentWord][currentVariation] +
                  "/3.jpg"
                }
                alt=""
              />
            </div>
          </>
        ) : (
          <div className="flex justify-center space-x-5">
            {words["1"][currentWord].map((variation) => (
              <div
                key={variation}
                className="flex items-center flex-col space-y-2 w-1/2 px-2"
              >
                <h2>{variation}</h2>
                <img
                  className="w-full h-64 object-cover"
                  src={"/images/exercises/" + variation + "/1.jpg"}
                  alt=""
                />
              </div>
            ))}
          </div>
        )}

        <button
          onClick={() => {
            if (currentVariation < words["1"][currentWord].length) {
              setCurrentVariation(currentVariation + 1);
            } else {
              setCurrentVariation(0);
              setCurrentWord(currentWord + 1);
            }
          }}
        >
          Siguiente
        </button>
      </div>
      <SpeakButton text="Hola, Fernando. ¿Cómo te sientes el día de hoy? Por favor selecciona una figura que represente tu estado de ánimo." />
      <BackButton route="/categories" type="menu" />
    </Layout>
  );
};

export default Ambiguity;
