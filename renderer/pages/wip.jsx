import SpeakButton from "../components/SpeakButton";
import Layout from "../components/Layout";
import Link from "next/link";

const WipScreen = ({ backRoute = "/categories" }) => (
  <Layout>
    <div className="flex w-full h-full justify-center items-center">
      <div className="flex flex-col items-center space-y-8 my-1">
        <h1>Trabajo en progreso</h1>
        <img src="/images/logo.png" />
        <Link href={backRoute}>
          <button className="m-5 bg-white text-gray-900 ">Volver</button>
        </Link>
      </div>
    </div>
    <SpeakButton text="Trabajo en progreso." />
  </Layout>
);

export default WipScreen;
