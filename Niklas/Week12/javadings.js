            document.addEventListener('DOMContentLoaded', function () {
                var clickCount = 0;
                var cps = 0;

                var counterElement = document.getElementById('counter');
                var cpsElement = document.getElementById('cps');
                var clickButton = document.getElementById('clickButton');

                function incrementCounter() {
                    clickCount++;
                    counterElement.textContent = clickCount;
                }

                function updateCPS() {
                    cpsElement.textContent = cps + " CPS";
                    cps = 0;
                }

                function resetCPSInterval() {
                    setInterval(updateCPS, 1000);
                }

                clickButton.addEventListener('click', function () {
                    incrementCounter();
                    cps++;
                });

                resetCPSInterval();
            });