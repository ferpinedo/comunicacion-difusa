import { Component, useEffect } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import { useState } from "react";

const words = [
  ["Aprehender", "Aprender"],
  ["Asia", "Hacia"],
  ["Ato", "Hato"],
  ["Balsa", "Valsa"],
  ["Botar", "Votar"],
  ["Baya", "Vaya", "Valla"],
  ["Sierra1", "Sierra2"],
  ["Bello"],
  ["Arrollo", "1"],
];
const Ambiguity = () => {
  const [currentWord, setCurrentWord] = useState(0);
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);

  return (
    <Layout>
      <span className="text-left ml-10 my-5 p-1 rounded-lg bg-gray-300">
        Ambiguedad > Nivel 1
      </span>
      <div className="w-full h-full flex flex-col justify-center items-center space-y-10">
        {currentVariation < words[currentWord].length ? (
          <>
            <h2>{words[currentWord][currentVariation]}</h2>
            <div className="flex space-x-5 w-11/12 justify-center">
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words[currentWord][currentVariation] +
                  "/1.jpg"
                }
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words[currentWord][currentVariation] +
                  "/2.jpg"
                }
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={
                  "/images/exercises/" +
                  words[currentWord][currentVariation] +
                  "/3.jpg"
                }
                alt=""
              />
            </div>{" "}
          </>
        ) : (
          <div className="flex justify-center space-x-5">
            {words[currentWord].map((variation) => (
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
            if (currentVariation < words[currentWord].length) {
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
    </Layout>
  );
};

export default Ambiguity;
