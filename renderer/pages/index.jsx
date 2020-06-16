import Link from "next/link";
import Layout from "../components/Layout";
import { useEffect, useState } from "react";

const SplashScreen = () => {
  const [isFirstTime, setIsFirstTime] = useState(false);
  useEffect(() => {
    const voice = localStorage.getItem("voice");
    setIsFirstTime(!voice);
  }, []);
  return (
    <Layout>
      <div className="flex w-full h-full justify-center items-center">
        <div className="flex flex-col items-center space-y-8 my-20">
          <h1>Comunicación difusa</h1>
          <img src="images/logo.png" />
          <Link href={isFirstTime ? `/settings` : `/login`}>
            <button>COMENZAR</button>
          </Link>
        </div>
      </div>
    </Layout>
  );
};

export default SplashScreen;
