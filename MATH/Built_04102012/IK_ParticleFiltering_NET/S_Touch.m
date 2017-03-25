function r = S_Touch(chain, S)
% S: 
% S = [O1 O2 ... Ok]
% Ok.ptos: lista de puntos 

cadena = chain2positions(chain);
r = 1;

b = size(cadena, 1);
for i = 1 : b-1
    % Crear el enlace a analizar
    p1.x = cadena(i, 1);
    p1.y = cadena(i, 2);
    p2.x = cadena(i+1, 1);
    p2.y = cadena(i+1, 2);
        
    % Poner en cuadrantes 1 o 2    
    if p1.y > p2.y %esta en los cuadrantes 3 o 4
        xtemp = p1.x;   ytemp = p1.y;
        p1.x = p2.x;    p1.y = p2.y;
        p2.x = xtemp;   p2.y = ytemp;
    end % ahora estan puestos en los cuadrantes 1 o 2
    
    % Escoger los obstaculos a los que se le hara la suma
    obst = max(size(S));
    % S_ = S;
    S_ = [];
    for k = 1 : obst
        tx = [S(k).ptos.x]; x_max = max(tx); x_min = min(tx);
        ty = [S(k).ptos.y]; y_max = max(ty); y_min = min(ty);
        if ~(p1.x < x_min && p2.x < x_min) || (p1.x > x_max && p2.x > x_max)
            S_ = [S_ S(k)];
        end
    end
    % Poner la cadena respecto al (0,0), crecerlo
    % y preguntar si el brazo esta dentro del poligono.
    temp.x = p2.x;   temp.y = p2.y;
    p2.x = p2.x - p1.x;
    p2.y = p2.y - p1.y;
    p1.x = 0; p1.y = 0;
    obst_ = max(size(S_));
    brazo.p1 = p1;
    brazo.p2 = p2;

    for k = 1 : obst_
        ptos_ = size(S_(k).ptos);
        S_(k).ptos = obstaculo_crecido(brazo, S_(k).ptos);
        r = r * (1 - dentro(S_(k), temp));
    end    
end