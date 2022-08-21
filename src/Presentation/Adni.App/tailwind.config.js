/** @type {import('tailwindcss').Config} */
const defaultTheme = require('tailwindcss/defaultTheme')

module.exports = {
  content: [
    "./src/**/*.{html,ts}",
  ],
  theme: {
    extend: {
      fontFamily: {
        'sans': ["Segoe UI Symbol", ...defaultTheme.fontFamily.sans]
      },
    },
  },
  plugins: [
      require('@tailwindcss/forms'),
  ],
}
