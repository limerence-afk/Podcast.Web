var background = document.getElementById("background");

document.getElementById("more-podcasts").addEventListener('click', (event) => {
    background.style.visibility = 'visible';
});

background.addEventListener('click', (event) => {
    background.style.visibility = 'hidden';
});