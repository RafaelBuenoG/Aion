const inpCoClass = document.querySelector('.select-modal-coclass');
const labelCoClass = document.querySelector('#label-modal-coclass')
const dropDownCoClass = document.querySelector('.dropdown-select-coclass');
const blurDropCoClass = document.querySelector('.modal-container-coclass')

const ActiveDropDownClassCoClass = 'dropdown-show-coclass';

const closeDropDownCoClass = () => {
    dropDownCoClass.classList.remove(ActiveDropDownClassCoClass);
    inpCoClass.blur()
}
const openDropDownCoClass = () => {
    dropDownCoClass.classList.add(ActiveDropDownClassCoClass);
    inpCoClass.blur()
}

inpCoClass.addEventListener('focus', () => {
    dropDownCoClass.classList.contains(ActiveDropDownClassCoClass) ? closeDropDownCoClass() : openDropDownCoClass()
})

blurDropCoClass.addEventListener('mousedown', (event) => {
    if (blurDropCoClass.contains(event.target) && !inpCoClass.contains(event.target)
    && !labelCoClass.contains(event.target))
    closeDropDownCoClass()
})

// Select Box

let itemsCoClass = ''

function selectCoClass(id)
{
    const nameItemCoClass = document.querySelector(`#items-coclass-${id}`).innerHTML

    itemsCoClass = nameItemCoClass

    document.querySelector('.select-modal-coclass').value = itemsCoClass;
}