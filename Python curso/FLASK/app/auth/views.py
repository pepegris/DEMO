from flask import *
from app.forms import Login_form
from . import auth

@auth.route('/login')
def login():

    login_form = Login_form()

    context={

          'login_form':login_form,

    }

    return render_template('login.html' , **context )