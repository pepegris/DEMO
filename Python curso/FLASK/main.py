from ensurepip import bootstrap
from venv import create
from flask import Flask , request ,make_response ,redirect , render_template ,session, url_for,flash
# from flask_bootstrap import Bootstrap
# from flask_wtf import FlaskForm
# from wtforms.fields import StringField , PasswordField ,SubmitField
# from wtforms.validators import DataRequired
import unittest

from app.create import create_app 
from app.forms import Login_form


app = create_app()

# app = Flask(__name__)
# #configurar FLASK al ejecutar
# app.config.update(
#     DEBUG=True,
#     ENV='development',
#     SECRET_KEY='CONFIG UPDATE',
#     TESTING=True
# )
# #app.config['SECRET_KEY'] = 'SUPER SECRETO'

# bootstrap = Bootstrap(app)

todos=['Compras Cafe' , 'Enviar Solicitud' , 'Comprar Pastel' , 'Comprar Pan']

# DEF PARA LAS ROUTAS HTTPS
@app.route('/')
def index():
    user_ip=request.remote_addr
    response=make_response(redirect('/hello'))
    session['user_ip']=user_ip
    #response.set_cookie('user_ip',user_ip)

    return response

@app.route('/hello',methods = ['GET','POST'])
def hello():
    user_ip = session.get('user_ip')
    login_form = Login_form()
    username = session.get('username')
    context={
         'user_ip':user_ip ,
          'todos':todos,
          'login_form':login_form,
          'username':username
    }

    if login_form.validate_on_submit():
        username = login_form.username.data
        username=username.lower()
        username=username.title()
        session['username']=username

        flash (f'Usuario Registrado con exito | {username} ')

        response=make_response(redirect('/recibido'))
        return response


    return render_template ('hello.html', **context)

@app.route('/recibido' ,methods = ['GET','POST'] )
def recibido():

    username = session.get('username')
    context={

        'username':username
    }

    if username != None :
        return render_template('recibido.html' , **context ) 
    else:
        response=make_response(redirect('/'))
        return response

        
       

    
    


        





# @app.cli.command()
# def test():
#     tests=unittest.TestLoader().discover(('tests'))
#     unittest.TextTestRunner().run(tests)





# ERRORES DE RUTA

@app.errorhandler(404)
def page_not_found(e):
    return render_template('error/404.html' , error=e)

@app.errorhandler(500)
def internal_server_error(e):
    return render_template('error/500.html' , error=e)


if __name__ == '__main__':
    app.run()

