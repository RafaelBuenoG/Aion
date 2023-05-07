const inp = document.querySelector('.select-modal');
const dropDown = document.querySelector('.dropdown-select');
const blurDrop = document.querySelector('.form-modal')

const ActiveDropDownClass = 'dropdown-show';

const openDropDown = () => dropDown.classList.add(ActiveDropDownClass);
const closeDropDown = () => dropDown.classList.remove(ActiveDropDownClass);


inp.addEventListener('focus', openDropDown);
// inp.addEventListener('blur', CloseDropDown);

blurDrop.addEventListener('mousedown', (event) => {
    if (!dropDown.contains(event.target)) closeDropDown()
    
    return;
})


let items = []

function category(c)
{
    const nameItem = document.querySelector(`#items-${c}`).innerHTML
    let pos = items.indexOf(nameItem)

    if (pos == -1)
    {
        items.push(nameItem)
    }
    else
    {
        items.splice(pos, 1)
    }

    document.querySelector('.select-modal').value = items;

    console.log('posicao: ' + pos);
    console.log('c: ' + c);
    console.log(items);
    console.log('----------------');
}