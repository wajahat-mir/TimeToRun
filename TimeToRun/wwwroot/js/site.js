// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
if ("serviceWorker" in navigator) {
    navigator.serviceWorker.register("js/sw.js").then(
        (registration) => {
            console.log("Service worker registration successful:", registration);
        },
        (error) => {
            console.error(`Service worker registration failed: ${error}`);
        },
    );
} else {
        console.error("Service workers are not supported.");
}