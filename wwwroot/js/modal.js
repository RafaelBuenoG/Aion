const getElement = (...queries) => document.querySelector(...queries);

const btnOpen = getElement('.btn-modal');
const btnClose = getElement('.close-modal');
const background = getElement('.modal');
const modal = getElement('.modal-container');
const formSubjects = getElement('#form-subjects')
const formTeachers = getElement('#form-teachers')
const form = getElement('#form')

const activeModalClass = 'modal-show';

const openModal = () => background.classList.add(activeModalClass);
const closeModal = () => background.classList.remove(activeModalClass);

btnOpen.addEventListener('click', openModal)
btnClose.addEventListener('click', closeModal)
// A diferença do mousedown pro click é que só quando o mouse for clicado a função será executada, e não quando soltado o clique.
background.addEventListener('mousedown', (event) => {
    if (!modal.contains(event.target)) closeModal()
    
    return;
})

// Limpar formulário dos professores

// form.addEventListener('submit', (event) => {
//     event.defaultPrevented();
// 
//     document.querySelector("[name='name']").value = ''
//     document.querySelector("[name='email']").value = ''
//     document.querySelector("[name='phone']").value = ''
//     document.querySelector("[name='subjects']").value = ''
// 
//     qtdeCheckboxes = document.querySelectorAll("[type='checkbox']")
//     for (var checkbox of qtdeCheckboxes) checkbox.checked = false

    // Deleta os itens no array do select
//     deleteItems()
// })