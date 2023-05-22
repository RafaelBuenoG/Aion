const getElement = (...queries) => document.querySelector(...queries);

const btnOpen = getElement('.btn-modal');
const btnClose = getElement('.close-modal');
const background = getElement('.modal');
const modal = getElement('.modal-container');

const btnOpenEdt = getElement('.btn-modal-edt');
const btnCloseEdt = getElement('.close-modal-edt');
const backgroundEdt = getElement('.modal-edt');
const modalEdt = getElement('.modal-container-edt');

const btnOpenDel = getElement('.btn-modal-del');
const btnCloseDel = getElement('.close-modal-del');
const backgroundDel = getElement('.modal-del');
const modalDel = getElement('.modal-container-del');

const prof = getElement('#prof-del')

const activeModalClass = 'modal-show';

const openModalDel = () => backgroundDel.classList.add(activeModalClass);
const closeModalDel = () => backgroundDel.classList.remove(activeModalClass);
const openModalEdt = () => backgroundEdt.classList.add(activeModalClass);
const closeModalEdt = () => backgroundEdt.classList.remove(activeModalClass);
const openModal = () => background.classList.add(activeModalClass);
const closeModal = () => background.classList.remove(activeModalClass);

btnOpenDel?.addEventListener('click', openModalDel)
btnCloseDel?.addEventListener('click', closeModalDel)
btnOpenEdt?.addEventListener('click', openModalEdt)
btnCloseEdt?.addEventListener('click', closeModalEdt)
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