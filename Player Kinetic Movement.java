<div class="board">
        <div class="shooter">
            <img src="img/cb.png" alt="" class="shooter-img">
        </div>
    </div>  

const player = document.querySelector('.shooter-img');

function moveRight() {
    let rightPosition = window.getComputedStyle(player).getPropertyValue('right')
    if(player.style.right === "0px"){
return
    }else {
        let position = parseInt(rightPosition)
        position += 4
        player.style.right = '${position}px'
    }
}

function moveLeft() {
    let rightPosition = window.getComputedStyle(player).getPropertyValue('right')
    if(player.style.right ==="360px") {
        return
    }else {
        let position = parseInt(rightPosition)
        position -= 4
        player.style.right = '${position}px'
    }
}

.new function playerMove(event) {
if(event.key === "ArrowRight") {
    event.preventDefault()
    moveRight()
}else if(event.key === "ArrowLeft") {
    event.preventDefault()
    moveLeft()
}else if(event.key === " ") {
    event.preventDefault()
    fireBullet()
}
}
window.addEventListener('keydown', playerMove);