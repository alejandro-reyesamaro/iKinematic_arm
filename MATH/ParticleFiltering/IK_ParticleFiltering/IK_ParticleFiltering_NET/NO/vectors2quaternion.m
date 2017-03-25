%Tohannic Project in Matlab
% author: Antoni Jaume i Capó
% version: 2.0
% date: 13/04/2010
% function: vectors2quaternion
%http://www.euclideanspace.com/maths/algebra/vectors/angleBetween/index.htm
%http://www.euclideanspace.com/maths/geometry/rotations/conversions/angleTo
% http://www.mathworks.com/matlabcentral/newsreader/view_thread/151925
% http://tomyeah.com/signed-angle-between-two-vectors3d-in-cc/
% http://www.xnawiki.com/index.php?title=Vector_Math
%Quaternion/index.htm
% description:  Compute the quaternion composed by two unit vectors
%               input: v1 origin, v2 destination
%               output: quaterion
function q= vectors2quaternion(v1,v2)
angle = acos(dot(v1,v2)/(norm(v1)*norm(v2)))
axis = cross(v1,v2);
if(norm(axis)~=0)
    axis = axis/norm(axis);
end

n = cross(v1,v2);
n = n/norm(n);
sinangle = dot(cross(v1,v2),n);
if(sinangle == 0)
    n = cross(v2,v1);
    n = n/norm(n);
    sinangle = dot(cross(v1,v2),n);
end
cosangle = dot(v1,v2);
theta = atan2(sinangle,cosangle)


% s = sin(angle/2);
s = 0.5*sin(angle)/cos(angle/2);
x = axis(1)*s;
y = axis(2)*s;
z = axis(3)*s;
s = cos(angle/2);
q = quaternion(s,[x,y,z]);
% q = quaternionNormalize(q);


% d= dot(v1,v2);
% axis = cross(v1,v2);
% qw = norm(v1)*norm(v2)+d;
% if(qw<0.0001) %180 grau
%     q = quaternion(0,[v1(3),v1(2),-v(1)]);
% else
%     q = quaternion(qw,[axis(1),axis(2),axis(3)]);
% end
% q = quaternionNormalize(q);


%COPIA
% angle = acos(dot(v1,v2)/(norm(v1)*norm(v2)));
% graus = 180*angle/pi
% axis = cross(v1,v2);
% if(norm(axis)~=0)
%     axis = axis/norm(axis);
% end
% s = sin(angle/2);
% x = axis(1)*s;
% y = axis(2)*s;
% z = axis(3)*s;
% s = cos(angle/2);
% q = quaternion(s,[x,y,z]);
% % q = quaternionNormalize(q);