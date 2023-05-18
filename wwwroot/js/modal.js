const getElement = (...queries) => document.querySelector(...queries);

const btnOpen = getElement('.btn-modal');
const btnClose = getElement('.close-modal');
const background = getElement('.modal');
const modal = getElement('.modal-container');

const btnOpenEdt = getElement('.btn-modal-edt');
const btnCloseEdt = getElement('.close-modal-edt');
const backgroundEdt = getElement('.modal-edt');
const modalEdt = getElement('.modal-container-edt');

const prof = getElement('#prof-del')
const backgroundDel = getElement('.modal-del')
const modalDel = getElement('.modal-container-del')

const activeModalClass = 'modal-show';

const openModalEdt = () => backgroundEdt.classList.add(activeModalClass);
const closeModalEdt = () => backgroundEdt.classList.remove(activeModalClass);
const openModal = () => background.classList.add(activeModalClass);
const closeModal = () => background.classList.remove(activeModalClass);

btnCloseEdt?.addEventListener('click', closeModalEdt)
btnOpenEdt?.addEventListener('click', openModalEdt)

function openModalDel()
{
    backgroundDel.classList.add(activeModalClass);
}

function closeModalDel()
{
    backgroundDel.classList.remove(activeModalClass);
}

btnOpen.addEventListener('click', openModal)
btnClose.addEventListener('click', closeModal)
// A diferença do mousedown pro click é que só quando o mouse for clicado a função será executada, e não quando soltado o clique.
background.addEventListener('mousedown', (event) => {
    if (!modal.contains(event.target)) closeModal()
    
    return;
})
backgroundEdt?.addEventListener('mousedown', (event) => {
    if (!modalEdt.contains(event.target)) closeModalEdt()
    
    return;
})

backgroundDel?.addEventListener('mousedown', (event) => {
    if (!modalDel.contains(event.target)) closeModalDel()
    
    return;
})