const inpCoClassEdt = document.querySelector('.select-modal-coclassEdt');
const labelCoClassEdt = document.querySelector('#label-modal-coclassEdt')
const dropDownCoClassEdt = document.querySelector('.dropdown-select-coclassEdt');
const blurDropCoClassEdt = document.querySelector('.modal-container-coclassEdt')

const ActiveDropDownClassCoClassEdt = 'dropdown-show-coclassEdt';

const closeDropDownCoClassEdt = () => {
    dropDownCoClassEdt.classList.remove(ActiveDropDownClassCoClassEdt);
    inpCoClassEdt.blur()
}
const openDropDownCoClassEdt = () => {
    dropDownCoClassEdt.classList.add(ActiveDropDownClassCoClassEdt);
    inpCoClassEdt.blur()
}

inpCoClassEdt.addEventListener('focus', () => {
    dropDownCoClassEdt.classList.contains(ActiveDropDownClassCoClassEdt) ? closeDropDownCoClassEdt() : openDropDownCoClassEdt()
})

blurDropCoClassEdt.addEventListener('mousedown', (event) => {
    if (blurDropCoClassEdt.contains(event.target) && !inpCoClassEdt.contains(event.target)
    && !labelCoClassEdt.contains(event.target))
    closeDropDownCoClassEdt()
})

// Select Box

let itemsCoClassEdt = ''

function selectCoClassEdt(id)
{
    const nameItemCoClassEdt = document.querySelector(`#items-coclassEdt-${id}`).innerHTML

    itemsCoClassEdt = nameItemCoClassEdt

    document.querySelector('.select-modal-coclassEdt').value = itemsCoClassEdt;
}