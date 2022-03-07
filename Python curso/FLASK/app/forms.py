from flask_wtf import FlaskForm
from wtforms.fields import StringField , PasswordField ,SubmitField
from wtforms.validators import DataRequired

#flask form clase

class Login_form (FlaskForm):
    username= StringField('Nombre del usuario' , validators=[DataRequired()] )
    password = PasswordField('Clave del usuario', validators=[DataRequired()])
    submit = SubmitField('Enviar')