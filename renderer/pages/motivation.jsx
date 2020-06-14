import { Component } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import BackButton from "../components/BackButton";
import SpeakButton from "../components/SpeakButton";

const feelings = [
  {
    name: "Muy feliz",
    emoji: "😃",
  },
  {
    name: "Feliz",
    emoji: "🙂",
  },
  {
    name: "Neutro",
    emoji: "😐",
  },
  {
    name: "Con sueño",
    emoji: "🥱",
  },
  {
    name: "Triste",
    emoji: "😢",
  },
  {
    name: "Enojado",
    emoji: "😡",
  },
];

export default class extends Component {
  render() {
    return (
      <Layout>
        <div className="content">
          <div className="title">
            <h1>Motivación</h1>
            <p>¿Cómo te sientes el día de hoy?</p>
          </div>
          <div style={{ display: "flex" }}>
            {feelings.map((feeling, index) => (
              <Link key={index} href={`/categories`}>
                <a>
                  <div>
                    <div
                      className="hover:shadow"
                      style={{
                        borderRadius: "999px",
                        marginRight: "15px",
                        fontSize: "90px",
                        textAlign: "center",
                      }}
                    >
                      {feeling.emoji}
                    </div>
                  </div>
                </a>
              </Link>
            ))}
          </div>
        </div>
        <SpeakButton text="Hola, Fernando. ¿Cómo te sientes el día de hoy? Por favor selecciona una figura que represente tu estado de ánimo." />
        <BackButton route="/login" />

        <style jsx>{`
          .student-card {
            display: flex;
            cursor: pointer;
            border-radius: 10px;
            cursor: pointer;
            padding: 10px;
            background-color: white;
            margin-bottom: 15px;
            align-items: center;
          }
          button {
            background-color: #5c9dc1;
            color: white;
          }
          .content {
            padding: 10px;
            display: flex;
            flex-direction: column;
            width: 100%;
            justify-content: center;
            align-items: center;
          }
          .title {
            display: flex;
            flex-direction: column;
            justify-content: center;
            text-align: center;
          }
        `}</style>
      </Layout>
    );
  }
}
