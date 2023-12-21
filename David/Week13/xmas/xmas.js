$(document).ready(function () {
    createSnowflakes();
});
function createSnowflakes() {
    var numberOfSnowflakes = 50;
    for (var i = 0; i < numberOfSnowflakes; i++) {
        createSnowflake();
    }
}
function createSnowflake() {
    var leftPosition = Math.random() * 100;
    var animationDuration = Math.random() * 5 + 5;
    var snowflake = $('<div class="snowflake"></div>');
    snowflake.css({
        left: leftPosition + 'vw',
        animationDuration: animationDuration + 's',
    });
    $('.snowflakes').append(snowflake);
}