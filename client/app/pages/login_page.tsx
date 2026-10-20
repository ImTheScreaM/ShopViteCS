import { useForm, type SubmitHandler } from "react-hook-form";
import { NavLink } from "react-router";
import type { IDataLoginAuth } from "~/shared/types";

export function LoginPage() {
	const {
		register,
		handleSubmit,
		formState: { errors },
	} = useForm<IDataLoginAuth>();

	const handleSubmitRegister: SubmitHandler<IDataLoginAuth> = (data) => {
		console.log(data);
	};

	return (
		<form
			onSubmit={handleSubmit(handleSubmitRegister)}
			className="grid justify-center gap-2"
		>
			<input
				className="border border-gray-300 focus:outline-none focus:border-blue-500"
				placeholder="Email"
				type="email"
				{...register("email", {
					required: "Email is required",
					pattern: { value: /^\S+@\S+\.\S+$/, message: "Invalid email" },
				})}
			/>

			<p>
				{errors.email && <span className="text-red-700">Invalid email</span>}
			</p>

			<input
				className="border border-gray-300 focus:outline-none focus:border-blue-500"
				type="password"
				placeholder="Password"
				{...register("password", {
					required: "Password is required",
				})}
			/>
			<p></p>
			<p>
				{errors.password && (
					<span className="text-red-700">Password is required</span>
				)}
			</p>
			<div className="flex justify-around">
				<button
					className="hover:bg-amber-500 transition duration-150 w-30 p-3"
					type="submit"
				>
					Submit
				</button>
				<NavLink className="w-30 p-3" to={"/register"}>
					<span className="hover:bg-amber-500 transition duration-150 w-30 p-3">
						Register
					</span>
				</NavLink>
			</div>
		</form>
	);
}
