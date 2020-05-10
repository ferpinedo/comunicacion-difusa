import { Component } from "react";
import Layout from "../components/Layout";
import Link from "next/link";

const students = [
  {
    name: "Fernando Pinedo",
    level: 2,
  },
  {
    name: "Kévin Hernandez",
    level: 3,
  },
  {
    name: "Matías Elizonda",
    level: 1,
  },
  {
    name: "Elías Sánchez",
    level: 5,
  },
];

export default class extends Component {
  render() {
    return (
      <Layout>
        <div className="content">
          <div className="title">
            <h1>Inicio de sesión</h1>
            <p>
              Selecciona tu sesión o crea una nueva presionando el botón azul.
            </p>
          </div>
          {students.map((student, index) => (
            <Link key={index} href={`/levels`}>
              <a>
                <div className="student-card">
                  <div
                    style={{
                      backgroundColor: "purple",
                      borderRadius: "999px",
                      width: "50px",
                      height: "50px",
                      marginRight: "10px",
                    }}
                  ></div>
                  <div>
                    <span>{student.name}</span>
                    <br />
                    <span>Nivel #{student.level}</span>
                  </div>
                </div>
              </a>
            </Link>
          ))}
        </div>

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
            width: 250px;
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
