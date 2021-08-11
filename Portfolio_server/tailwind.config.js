module.exports = {
    purge: [],
    darkMode: false, // or 'media' or 'class'
    theme: {
        extend: {
            keyframes: {
                opacity_show: {
                    '0%': { opacity:0 },
                    '100%': { opacity:1 }
                },
                opacity_hide: {
                    '0%': { opacity:1 },
                    '100%': { opacity:0  }
                },

                menu_show: {
                    '0%': { transform: 'translateX(-100%)' },
                    '100%': { transform: 'translateX(0)' }
                },
                menu_hide: {
                    '0%': { transform: 'translateX(0)' },
                    '100%': { transform: 'translateX(-100%)' }
                },
            },
            animation: {
                opacity_show: 'opacity_show 0.3s ease-in-out both',
                opacity_hide: 'opacity_hide 0.3s ease-in-out both',
                menu_show: 'menu_show 0.3s ease-in-out both',
                menu_hide: 'menu_hide 0.3s ease-in-out both',
            },
        },
    },
    variants: {},
    plugins: [
// ...
        require('@tailwindcss/forms'),
    ],
}
