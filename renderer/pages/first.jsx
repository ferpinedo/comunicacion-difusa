import { Component } from "react";
import Layout from "../components/Layout";
import Link from "next/link";

const students = [
  {
    name: "Fernando Pinedo",
    level: "😃",
  },
  {
    name: "Fernando Pinedo",
    level: "🙂",
  },
  {
    name: "Fernando Pinedo",
    level: "🤨",
  },
  {
    name: "Kévin Hernandez",
    level: "😐",
  },
  {
    name: "Matías Elizonda",
    level: "🥱",
  },
  {
    name: "Elías Sánchez",
    level: "😡",
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
            {students.map((student, index) => (
              <Link key={index} href={`/first`}>
                <a>
                  <div className="">
                    <div
                      style={{
                        borderRadius: "999px",
                        width: "50px",
                        height: "50px",
                        marginRight: "15px",
                        fontSize: "30px",
                        textAlign: "center",
                      }}
                    >
                      {student.level}
                    </div>
                  </div>
                </a>
              </Link>
            ))}
          </div>
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
