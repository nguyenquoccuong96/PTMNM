#commit lan 1
clear

echo "Nhap n: "
read n

sum=0
i=0

if [[ $n -gt 0 ]]
then

	while [[ $i -lt $n ]]
	do
		echo -n "Nhap so thu $(($i+1)) "
		read number
		eval arr[$i]=$number

		i=$(($i+1))
	
		#tinh tong
		sum=$(( $sum+$number ))


	done
else
	clear
	echo "N>0"

	exit 1
fi


echo "IN RA DAY VUA NHAP "
i=0
while [[ $i -lt $n ]]
do
	echo "arr[$i]= ${arr[$i]}"
	i=$(($i+1))

done
echo "TONG LA $sum"
#-----------------------------------------------------------
#commit lan 2

for (( i = 0; i < $(($n-1)) ; i++ ))
do
   for (( j = $i; j < $n; j++ ))
   do

      if [[ ${arr[$i]} -gt ${arr[$j]} ]]
      then

       t=${arr[$i]}
       arr[$i]=${arr[$j]}
       arr[$j]=$t
      fi
   done
done

for (( i = 0; i < $n ; i++ ))
do
echo "arr[$i] : ${arr[$i]}"
done
