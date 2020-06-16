import { Component, useEffect, useState } from "react";
import Layout from "../components/Layout";
import Link from "next/link";
import BackButton from "../components/BackButton";
import UserIcon from "../public/icons/user.svg";
import EditIcon from "../public/icons/edit.svg";
import SettingsIcon from "../public/icons/settings.svg";
import { observer, inject } from "mobx-react";
import { useRouter } from "next/router";

const LogIn = ({ store }) => {
  const [students, setStudents] = useState([]);
  const router = useRouter();
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
          <Link key={index} href={`/changecontrol`}>
            <a
              onClick={() => (store.results = { ...student, date: new Date() })}
            >
              <div className="student-card shadow-md hover:bg-white bg-gray-100">
                <div className="bg-gray-300 rounded-full flex justify-center items-center p-3 mr-5">
                  <UserIcon width="32px" height="32px" fill="#B49ACA" />
                </div>
                <div className="w-full">
                  <div className="mb-2">{student.name}</div>
                  <div
                    className="cursor-pointer float-right m-1"
                    onClick={(event) => {
                      event.preventDefault();
                      store.editingStudent = student;
                      router.push("/newstudent");
                    }}
                  >
                    <EditIcon width="15px" height="15px" />
                  </div>
                </div>
              </div>
            </a>
          </Link>
        ))}
      </div>
      <Link href="/settings">
        <a className="absolute right-0 bottom-0 m-5">
          <SettingsIcon width="40px" height="40px" />
        </a>
      </Link>
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
export default inject("store")(observer(LogIn));
