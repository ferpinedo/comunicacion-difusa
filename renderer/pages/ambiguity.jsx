import { Component, useEffect } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import { useState } from "react";

const variations = [
  {
    name: "Votar",
    imagesPath: "/images/excercises/Votar/",
  },
  {
    name: "Votar",
    imagesPath: "/images/excercises/Botar/",
  },
];

const Ambiguity = () => {
  const [currentVariation, setCurrentVariation] = useState(0);
  const [showTest, setShowTest] = useState(false);
  useEffect(() => {
    setTimeout(() => {
      setCurrentVariation(1);
    }, 5000);
    setTimeout(() => {
      setShowTest(true);
    }, 10000);
  }, []);
  return (
    <Layout>
      <div className="w-full h-full flex flex-col justify-center items-center">
        <h1>{variations[currentVariation].name}</h1>
        <div className="flex space-x-8">
          <img src={"/images/excercises/Votar/1.jpg"} alt="" />
          <img src={variations[currentVariation].imagesPath + "2.jpg"} alt="" />
          <img src={variations[currentVariation].imagesPath + "3.jpg"} alt="" />
        </div>
      </div>
    </Layout>
  );
};

export default Ambiguity;
