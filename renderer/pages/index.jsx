import Link from "next/link";
import Layout from "../components/Layout";

const SplashScreen = () => (
  <Layout>
    <div className="flex w-full h-full justify-center items-center">
      <div className="flex flex-col items-center space-y-8 mt-20">
        <h1>Comunicación difusa</h1>
        <img src="/images/logo.png" />
        <Link href={`/login`}>
          <button>COMENZAR</button>
        </Link>
      </div>
    </div>
  </Layout>
);

export default SplashScreen;
