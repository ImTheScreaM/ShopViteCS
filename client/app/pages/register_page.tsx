import { useForm, type SubmitHandler } from "react-hook-form";
import { NavLink } from "react-router";
import type { IDataRegisterAuth } from "~/shared/types";

export function RegisterPage() {
	const {
		register,
		handleSubmit,
		formState: { errors },
	} = useForm<IDataRegisterAuth>();

	const handleSubmitRegister: SubmitHandler<IDataRegisterAuth> = (data) => {
		console.log(data);
	};

	return (
		<form
			onSubmit={handleSubmit(handleSubmitRegister)}
			className="grid justify-center gap-2"
		>
			<input
				className="border border-gray-300 focus:outline-none focus:border-blue-500"
				placeholder="Name"
				type="text"
				{...register("userName", {
					required: "First name is required",
					minLength: { value: 2, message: "Min length is 2" },
				})}
			/>
			<p className="text-red-700">{errors.userName?.message}</p>

			<input
				className="border border-gray-300 focus:outline-none focus:border-blue-500"
				placeholder="Email"
				type="email"
				{...register("email", {
					required: "Email is required",
					pattern: { value: /^\S+@\S+\.\S+$/, message: "Invalid email" },
				})}
			/>

			<p className="text-red-700">{errors.email?.message}</p>

			<input
				className="border border-gray-300 focus:outline-none focus:border-blue-500"
				type="password"
				placeholder="Password"
				{...register("password", {
					required: "Password is required",
					minLength: { value: 6, message: "Min length is 6" },
				})}
			/>

			<p className="text-red-700">{errors.password?.message}</p>

			<input
				type="number"
				{...register("age", {
					valueAsNumber: true,
					required: "Age is required",
				})}
			/>
			<p className="text-red-700">{errors.age?.message}</p>

			<div className="flex justify-around">
				<button
					className="hover:bg-amber-500 transition duration-150 w-30 p-3"
					type="submit"
				>
					Submit
				</button>
				<NavLink className="w-30 p-3" to={"/login"}>
					<span className="hover:bg-amber-500 transition duration-150 w-30 p-3">
						Login
					</span>
				</NavLink>
			</div>
		</form>
	);
}
