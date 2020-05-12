import { Component, useEffect } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import { useState } from "react";

const variations = [
  {
    name: "Votar",
    imagesPath: "/images/exercises/Votar/",
  },
  {
    name: "Botar",
    imagesPath: "/images/exercises/Botar/",
  },
];

const Ambiguity = () => {
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);

  return (
    <Layout>
      <span className="text-left ml-10 my-5 p-1 rounded-lg bg-gray-300">
        Ambiguedad > Nivel 1
      </span>
      <div className="w-full h-full flex flex-col justify-center items-center space-y-10">
        {currentVariation < 2 ? (
          <>
            <h2>{variations[currentVariation].name}</h2>
            <div className="flex space-x-5 w-11/12 justify-center">
              <img
                className="w-1/3 h-64 object-cover"
                src={variations[currentVariation].imagesPath + "1.jpg"}
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={variations[currentVariation].imagesPath + "2.jpg"}
                alt=""
              />
              <img
                className="w-1/3 h-64 object-cover"
                src={variations[currentVariation].imagesPath + "3.jpg"}
                alt=""
              />
            </div>{" "}
          </>
        ) : (
          <div className="flex justify-center space-x-5">
            {variations.map((variation) => (
              <div
                key={variation.name}
                className="flex items-center flex-col space-y-2 w-1/2 px-2"
              >
                <h2>{variation.name}</h2>
                <img
                  className="w-full h-64 object-cover"
                  src={variation.imagesPath + "1.jpg"}
                  alt=""
                />
              </div>
            ))}
          </div>
        )}

        <button onClick={() => setCurrentVariation(currentVariation + 1)}>
          Siguiente
        </button>
      </div>
    </Layout>
  );
};

export default Ambiguity;
