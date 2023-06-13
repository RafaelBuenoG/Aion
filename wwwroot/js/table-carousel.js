const controls = document.querySelectorAll('.control')

let currentItem = 0;
const items = document.querySelectorAll('.grid-table')
const maxItems = items.length

controls.forEach(control => {
    control.addEventListener('click', () => {
        const isLeft = control.classList.contains('arrow-left')
        
        isLeft ? currentItem -= 1 : currentItem += 1
        
        if (currentItem >= maxItems) currentItem = 0
        
        if (currentItem < 0) currentItem = maxItems - 1
        
        items.forEach(item =>
        item.classList.remove('current-grid-table'))
            items[currentItem].scrollIntoView({
                inline: "center",
                behavior: "smooth"
        })

        items[currentItem].classList.add('current-grid-table')
    })
})