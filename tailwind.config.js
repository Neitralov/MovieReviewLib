/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Pages/*.razor",
        "./Shared/**/*.razor",
    ],
    theme: {
        extend: {
            boxShadow: {
                'top' : '0 -1px 3px 0 rgba(0, 0, 0, 0.1)',
            }
        },
    },
    plugins: [],
}

