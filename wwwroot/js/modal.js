const getElement = (...queries) => document.querySelector(...queries);

const btn = getElement('.btn-modal');
const btnClose = getElement('.close-modal')
const background = getElement('.modal');
const modal = getElement('.form-modal');

const activeModalClass = 'modal-show';

const openModal = () => background.classList.add(activeModalClass);
const closeModal = () => background.classList.remove(activeModalClass);

btn.addEventListener('click', openModal)
btnClose.addEventListener('click', closeModal)
background.addEventListener('click', (event) => {
    if (!modal.contains(event.target)) closeModal()
    
    return;
})