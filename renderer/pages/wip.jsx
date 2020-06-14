import SpeakButton from "../components/SpeakButton";
import { Router } from "next/router";

const SplashScreen = () => (
  <Layout>
    <div className="flex w-full h-full justify-center items-center">
      <div className="flex flex-col items-center space-y-8 my-20">
        <h1>Trabajo en progreso</h1>
        <img src="/images/logo.png" />
        <button
          className="m-5 bg-white text-gray-900 absolute bottom-0"
          onClick={() => Router.back()}
        >
          Volver
        </button>
        <SpeakButton text="Trabajo en progreso." />
      </div>
    </div>
  </Layout>
);

export default SplashScreen;
