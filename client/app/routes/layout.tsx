import {
	Outlet,
	NavLink,
	useRouteError,
	isRouteErrorResponse,
} from "react-router";

export default function Layout() {
	return (
		<div>
			<header>
				<NavLink to={"/"}>Главная</NavLink>
				<NavLink to={"/product"}>Каталог</NavLink>
				<NavLink to={"/basket"}>Корзина</NavLink>
				<NavLink to={"/login"}>Регистрация</NavLink>
				<NavLink to={"/user"}>Профиль</NavLink>
			</header>
			<main>
				<Outlet />
			</main>
		</div>
	);
}

export function ErrorBoundary() {
	const error = useRouteError();

	if (isRouteErrorResponse(error)) {
		return (
			<div className="flex flex-col h-screen w-full items-center justify-center text-center">
				<span className="text-5xl">
					{error.status}:{error.statusText}
				</span>
				<NavLink className="text-3xl" to={"/"}>
					<span>На главную</span>
				</NavLink>
			</div>
		);
	}
	return (
		<div className="flex flex-col h-screen w-full items-center justify-center text-center">
			<span className="text-5xl">Что-то сломалось</span>
			<NavLink className="text-3xl" to={"/"}>
				<span>На главную</span>
			</NavLink>
		</div>
	);
}
