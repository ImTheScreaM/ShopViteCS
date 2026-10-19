import { Outlet, NavLink } from "react-router";

export default function Layout() {
	return (
		<div>
			<header>
				<NavLink to={"/"}>Главная</NavLink>
				<NavLink to={"/product"}>Каталог</NavLink>
				<NavLink to={"/basket"}>Корзина</NavLink>
			</header>
			<main>
				<Outlet/>
			</main>
		</div>
	)
}