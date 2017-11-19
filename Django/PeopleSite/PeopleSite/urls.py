"""PeopleSite URL Configuration

The `urlpatterns` list routes URLs to views. For more information please see:
    https://docs.djangoproject.com/en/1.11/topics/http/urls/
Examples:
Function views
    1. Add an import:  from my_app import views
    2. Add a URL to urlpatterns:  url(r'^$', views.home, name='home')
Class-based views
    1. Add an import:  from other_app.views import Home
    2. Add a URL to urlpatterns:  url(r'^$', Home.as_view(), name='home')
Including another URLconf
    1. Import the include() function: from django.conf.urls import url, include
    2. Add a URL to urlpatterns:  url(r'^blog/', include('blog.urls'))
"""
from django.conf.urls import url
from django.contrib import admin

from Person import views

app_name = 'Person'

urlpatterns = [
    # /Person/
    url(r'^$', views.current_person, name='current_people'),
    # /Person/242
    url(r'^Person/(?P<person_id>[0-9]+)/$', views.get_details, name='current_person_details'),

    # /Person/favourite/
    url(r'^Person/(?P<person_id>[0-9]+)/favourite/$', views.favourite, name='favourite'),

    # /admin/
    url(r'^admin/', admin.site.urls),
]
