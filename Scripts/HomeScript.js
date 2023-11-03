const rightbtn = document.querySelector('.next')
const leftbtn = document.querySelector('.prev')
const imgNumber = document.querySelectorAll('.slider-top img')
let index = 0

rightbtn.addEventListener("click", function () {
    index = index + 1
    if (index > imgNumber.length - 1) {
        index = 0
    }
    document.querySelector(".slider-top").style.right = index * 100 + "%"  
})

leftbtn.addEventListener("click", function () {
    index = index - 1
    if (index < 0) {
        index = imgNumber.length - 1
    }
    document.querySelector(".slider-top").style.right = index * 100 + "%"    
})



const navBtn = document.querySelectorAll('.slider-bottom button')


navBtn.forEach(function (image, index) {
    image.addEventListener("click", function () {
        removeActive()
        document.querySelector(".slider-top").style.right = index * 100 + "%"
        image.classList.add("active")
    })
})

function removeActive() {
    let navActive = document.querySelector('.active')
    navActive.classList.remove("active")
}


function imgAuto() {
    index = index + 1
    if (index > imgNumber.length - 1) {
        index = 0
    }
    removeActive()
    document.querySelector(".slider-top").style.right = index * 100 + "%"
    navBtn[index].classList.add("active")
}
setInterval(imgAuto, 5000)


/*const mainItems = document.querySelectorAll('.menu-main li')

function removeActiveLi() {
    let liActive = document.querySelector('.i-active')
    liActive.classList.remove('i-active')
}

mainItems.forEach(function (item,index){
    item.addEventListener("click", function () {
        removeActiveLi()
   
        item.classList.add('i-active')
    })
})*/