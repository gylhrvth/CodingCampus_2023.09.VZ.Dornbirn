let toggled = false

function onDateClick() {
    if (toggled) {
        document.getElementById('demo').innerHTML = null
    } else {
        document.getElementById('demo').innerHTML = Date()
    }
    toggled = !toggled
}