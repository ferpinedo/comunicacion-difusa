import SpeakButton from "../components/SpeakButton";
import Layout from "../components/Layout";
import WipIcon from "../public/icons/wip.svg";
import BackButton from "../components/BackButton";
import { inject, observer } from "mobx-react";
import Link from "next/link";
import NextIcon from "../public/icons/next.svg";

const ChangeControl = ({ store }) => (
  <Layout>
    <div className="flex w-full h-full justify-center items-center">
      <div className="flex flex-col items-center text-center space-y-20 m-8">
        <h1>Pasa el control de la computadora a {store.results.name}</h1>
        <Link href="/motivation">
          <a className="cursor-pointer">
            <NextIcon width="60px" height="60px" fill="#5C9DC1" />
          </a>
        </Link>
      </div>
    </div>
    <BackButton type="menu" route="/login" />
  </Layout>
);

export default inject("store")(observer(ChangeControl));
