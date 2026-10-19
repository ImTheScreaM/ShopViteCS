import { reactRouter } from "@react-router/dev/vite";
import tailwindcss from "@tailwindcss/vite";
import { defineConfig,loadEnv } from "vite";

export default defineConfig(({mode}) => {
	const env = loadEnv(mode, process.cwd(), "");
	Object.assign(process.env, env);

	return {
		plugins: [tailwindcss(), reactRouter()],
	  resolve: {
	    tsconfigPaths: true,
	  },
	}
});

