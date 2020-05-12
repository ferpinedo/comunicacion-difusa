import { Component } from "react";
import Layout from "../components/Layout";
import Link from "next/link";

const levels = [
  {
    name: "Ambiguedad",
    emoji: "🔀",
  },
  {
    name: "Inconsistencia",
    emoji: "🧶",
  },
  {
    name: "Vaguedad",
    emoji: "🥛",
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
              <Link key={index} href={`/levels`}>
                <a>
                  <div className="shadow-md rounded-full hover:bg-white w-48 h-48 flex flex-col p-4 justify-center items-center">
                    <span style={{ fontSize: "70px" }}>{level.emoji}</span>
                    <span>{level.name}</span>
                  </div>
                </a>
              </Link>
            ))}
          </div>

          <p className="mt-8">Calificación actual: 80/100</p>
        </div>

        <style jsx>{``}</style>
      </Layout>
    );
  }
}
