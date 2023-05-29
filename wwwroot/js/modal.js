const getElement = (...queries) => document.querySelector(...queries);

const btnOpen = getElement('.btn-modal');
const btnClose = getElement('.close-modal');
const background = getElement('.modal');
const modal = getElement('.modal-container');

const btnCloseEdt = getElement('.close-modal-edt');
const backgroundEdt = getElement('.modal-edt');
const modalEdt = getElement('.modal-container-edt');

const btnCloseDel = getElement('.close-modal-del');
const backgroundDel = getElement('.modal-del');
const modalDel = getElement('.modal-container-del');

const activeModalClass = 'modal-show';

const openModal = () => background.classList.add(activeModalClass);
const closeModal = () => {
    background.classList.remove(activeModalClass);
    closeDropDown();
}

function openModalDel(id, name)
{
    backgroundDel.classList.add(activeModalClass);
    let nameTxt = getElement('#name-del');
    nameTxt.innerText = name;

    let inpSub = getElement('#id-del')
    inpSub.value = id;
}
const closeModalDel = () => backgroundDel.classList.remove(activeModalClass);

function openModalEdtCursos(id, name, type, qty)
{
    backgroundEdt.classList.add(activeModalClass);
    let inpName = getElement('#name-edt');
    let inpType = getElement('#select-modal-typecoEdt');
    let inpQty = getElement('#qtySem-edt');
    inpName.value = name;
    inpType.value = type;
    inpQty.value = qty;

    let inpSub = getElement('#id-edt');
    inpSub.value = id;
}

function openModalEdtProfessores(id, name, email, phone, materias)
{
    backgroundEdt.classList.add(activeModalClass);
    
    let inpName = getElement('#name-edt');
    let inpEmail = getElement('#email-edt');
    let inpPhone = getElement('#phone-edt');
    inpName.value = name;
    inpEmail.value = email;
    inpPhone.value = phone;

    let inpSub = getElement('#id-edt');
    inpSub.value = id;

    let materiaId = materias.split(',');
    for (i = 0; i < materiaId.length; i++)
    {   
        let input = document.querySelector(`#item-select-edt-${materiaId[i]}`)
        const nameItemEdta = document.querySelector(`#items-edt-${materiaId[i]}`).innerHTML

        let posEdta = itemsEdt.indexOf(nameItemEdta)
        if (posEdta == -1)
        {
            itemsEdt.push(nameItemEdta)
            input.checked = true;
        }
        document.querySelector('.select-modal-edt').value = itemsEdt;
        
        // Quando o modal for fechado os itens do select perdem o atributo "checked"
        backgroundEdt?.addEventListener('mousedown', (event) => {
            if (!modalEdt.contains(event.target)) checkFalse(input)
        })  
    }
}

const checkFalse = (input) => {
    input.checked = false;
}

const closeModalEdt = () => {
    backgroundEdt.classList.remove(activeModalClass)
    closeDropDownEdt();
    deleteItemsEdt();
};

btnCloseDel.addEventListener('click', closeModalDel)
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
backgroundDel.addEventListener('mousedown', (event) => {
    if (!modalDel.contains(event.target)) closeModalDel()
    
    return;
})