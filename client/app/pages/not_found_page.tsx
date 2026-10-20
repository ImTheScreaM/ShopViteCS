import { NavLink } from "react-router";

export function NotFoundPage() {
	return (
		<div className="flex flex-col h-screen w-full items-center justify-center text-center">
			<span className="text-5xl"> 404 Error</span>
			<NavLink className="text-3xl" to={"/"}>
				<span>На главную</span>
			</NavLink>
		</div>
	);
}
