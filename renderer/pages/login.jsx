import { Component, useEffect, useState } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import BackButton from "../components/BackButton";

const LogIn = () => {
  const [students, setStudents] = useState([]);
  useEffect(() => {
    let localStudents = JSON.parse(localStorage.getItem("students"));
    if (!localStudents) {
      localStudents = [];
    }
    setStudents(localStudents);
  }, []);

  return (
    <Layout>
      <div className="content">
        <div className="title">
          <h1>Inicio de sesión</h1>
          <p>
            Selecciona la sesión del estudiante o crea una nueva presionando el
            botón azul.
          </p>
        </div>
        <Link href={`/newstudent`}>
          <button className="student-card text-center">
            + Agregar un nuevo alumno
          </button>
        </Link>
        {students.map((student, index) => (
          <Link key={index} href={`/motivation`}>
            <a>
              <div className="student-card shadow-md hover:bg-white bg-gray-100">
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
                </div>
              </div>
            </a>
          </Link>
        ))}
      </div>
      <BackButton route="/" />

      <style jsx>{`
        .student-card {
          display: flex;
          cursor: pointer;
          border-radius: 10px;
          cursor: pointer;
          padding: 10px;

          margin-bottom: 15px;
          align-items: center;
          width: 250px;
        }
        button {
          background-color: #5c9dc1 !important;
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
};
export default LogIn;
