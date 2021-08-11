const colors = require('tailwindcss/colors')

module.exports = {
    purge: [],
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            colors: {
                rose: colors.rose,
                sky:colors.sky,
                blueGray:colors.blueGray,
                coolGray: colors.coolGray,
                sky:colors.sky
                
            },
            keyframes: {
                openmenu: {
                    '0%': { transform: 'scale(0)',opacity:0 },
                    '100%': { transform: 'scale(1)',opacity:1 }
                },
                closemenu: {
                    '0%': { transform: 'scale(1)',opacity:1 },
                    '100%': { transform: 'scale(0)',opacity:0  }
                },
            },
            animation: {
                openmenu: 'openmenu 0.3s ease-in-out both',
                closemenu: 'closemenu 0.2s ease-in-out both',

            },
        },
    },
    variants: {
        extend:{
            padding:['hover'],
            filter:['hover'],
            grayscale:['hover']
        }
    },
    plugins: [
        require('@tailwindcss/forms'),
        require('@tailwindcss/aspect-ratio'),
    ]
}