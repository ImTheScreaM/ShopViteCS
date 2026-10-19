import type { Route } from "./+types/home";
import { WelcomePage } from "../pages/welcome_page";

export function meta({}: Route.MetaArgs) {
  return [
    { title: "New React Router App" },
    { name: "description", content: "Welcome to React Router!" },
  ];
}

export default function Home() {
  return <WelcomePage/>;
}

