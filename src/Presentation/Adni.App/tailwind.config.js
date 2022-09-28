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
      boxShadow: {
        '2lg': '0 0 -4px 0 #111827',
      }
    },
  },
  plugins: [
      require('@tailwindcss/forms'),
  ],
}
