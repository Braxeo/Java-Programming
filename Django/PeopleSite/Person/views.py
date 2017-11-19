<<<<<<< HEAD
from django.shortcuts import render, get_object_or_404
from .models import Person, Item

def current_person(request):
    all_persons = Person.objects.all()
    return render(request, 'Person/index.html', {'all_persons' : all_persons})

def get_details(request, person_id):
    person = get_object_or_404(Person, pk=person_id)

    return render(request, 'Person/detail.html', {'person' : person})

def favourite(request, person_id):
    person = get_object_or_404(Person, pk=person_id)

    try:
        selected_item = person.item_set.get(pk=request.POST['item'])
    except(KeyError, Item.doesNotExist):
        return render(request, 'Person/detail.html', {'person' : person, 'error_message' : "You did not select a valid song!",})
    else:
        selected_item.is_favourite = True
        selected_item.save()
        return render(request, 'Person/detail.html', {'person' : person})
=======
from django.shortcuts import render, get_object_or_404
from .models import Person, Item

def current_person(request):
    all_persons = Person.objects.all()
    return render(request, 'Person/index.html', {'all_persons' : all_persons})

def get_details(request, person_id):
    person = get_object_or_404(Person, pk=person_id)

    return render(request, 'Person/detail.html', {'person' : person})

def favourite(request, person_id):
    person = get_object_or_404(Person, pk=person_id)

    try:
        selected_item = person.item_set.get(pk=request.POST['item'])
    except(KeyError, Item.doesNotExist):
        return render(request, 'Person/detail.html', {'person' : person, 'error_message' : "You did not select a valid song!",})
    else:
        selected_item.is_favourite = True
        selected_item.save()
        return render(request, 'Person/detail.html', {'person' : person})
>>>>>>> 876b41aeb823c6e366286fa3d8fee5e3c2b1eb21
