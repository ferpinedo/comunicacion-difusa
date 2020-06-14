import { Component } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import BackButton from "../components/BackButton";
import SpeakButton from "../components/SpeakButton";

const levels = [
  {
    name: "Ambiguedad",
    emoji: "🔀",
    route: "/levels",
  },
  {
    name: "Inconsistencia",
    emoji: "🧶",
    route: "/wip",
  },
  {
    name: "Vaguedad",
    emoji: "🥛",
    route: "/wip",
  },
];

export default class extends Component {
  render() {
    return (
      <Layout>
        <div className="w-full h-full flex flex-col justify-center items-center">
          <h1>Categoría</h1>
          <p>Selecciona una categoría</p>
          <div className="flex space-x-8">
            {levels.map((level, index) => (
              <Link key={index} href={level.route}>
                <a>
                  <div className="shadow-md rounded-full bg-gray-100 hover:bg-white w-48 h-48 flex flex-col p-4 justify-center items-center">
                    <span style={{ fontSize: "70px" }}>{level.emoji}</span>
                    <span>{level.name}</span>
                  </div>
                </a>
              </Link>
            ))}
          </div>
        </div>
        <BackButton route="/motivation" />
        <SpeakButton text="Seleccion la categoría en la que deseas jugar hoy." />

        <style jsx>{``}</style>
      </Layout>
    );
  }
}
