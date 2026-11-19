import react from '@vitejs/plugin-react'
import { defineConfig } from 'vite'

export default defineConfig({
  plugins: [react()],
  server: {
    proxy: {
      '/api': {
        target: 'https://localhost:7061',
        changeOrigin: true,
        secure: false,  //change this before deploying to production very important cybersecurity don't forget
      },
    },
  },
})