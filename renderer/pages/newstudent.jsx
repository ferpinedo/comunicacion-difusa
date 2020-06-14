import Layout from "../components/Layout";
import { useState } from "react";
import { useRouter } from "next/router";
import BackButton from "../components/BackButton";

const NewStudent = ({ student = {} }) => {
  const isEditing = student.name;
  const [name, setName] = useState(student.name || "");
  const [birthdate, setBirthdate] = useState(student.birthdate || "");
  const [details, setDetails] = useState(student.details || "");
  const router = useRouter();

  const onSave = (e) => {
    e.preventDefault();
    let students = JSON.parse(localStorage.getItem("students"));
    if (!students) {
      students = [];
    }
    console.log(JSON.stringify(students));
    students.push({
      name,
      birthdate,
      details,
    });
    localStorage.setItem("students", JSON.stringify(students));
    router.push("/login");
  };

  return (
    <Layout>
      <div className="content">
        <div className="title">
          <h1>Nuevo alumno</h1>
        </div>

        <form onSubmit={onSave}>
          <label htmlFor="name">Nombre completo</label>
          <input
            type="text"
            name="name"
            id="name"
            value={name}
            required
            onChange={(e) => setName(e.target.value)}
          />
          <label htmlFor="birthdate">Fecha de nacimiento</label>
          <input
            type="date"
            name="birthdate"
            id="birthdate"
            value={birthdate}
            required
            onChange={(e) => setBirthdate(e.target.value)}
          />
          <label htmlFor="details">Observaciones</label>
          <input
            type="text"
            name="details"
            id="details"
            value={details}
            required
            onChange={(e) => setDetails(e.target.value)}
          />
          <div className="buttons flex justify-center space-x-4 my-4">
            {isEditing && (
              <button type="button" className="bg-red-500">
                Eliminar
              </button>
            )}
            <button className="bg-primary">Guardar</button>
          </div>
        </form>
      </div>
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
          width: 250px;
        }
        button {
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

export default NewStudent;