from flask import Flask , request ,make_response ,redirect , render_template

app = Flask(__name__)


todos=['Compras Cafe' , 'Enviar Solicitud' , 'Comprar Pastel' , 'Comprar Pan']

@app.route('/')
def index():
    user_ip=request.remote_addr
    response=make_response(redirect('/hello'))
    response.set_cookie('user_ip',user_ip)

    return response

@app.route('/hello')
def hello():
    user_ip = request.cookies.get('user_ip')
    context={
         'user_ip':user_ip ,
          'todos':todos
    }
    return render_template ('hello.html', **context)

# ERRORES DE RUTA

@app.errorhandler(404)
def page_not_found(e):
    return render_template('error/404.html' , error=e)

@app.errorhandler(500)
def internal_server_error(e):
    return render_template('error/500.html' , error=e)


if __name__ == '__main__':
    app.run(debug=True)

