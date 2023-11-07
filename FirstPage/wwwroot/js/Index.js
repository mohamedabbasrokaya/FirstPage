let inputdata=['html',
               'javascript',
            'css',
            'how to create aweb site',
            'mohamed ali',
            'cs76e56',
            'bankmasr',
            'how make it',
            'how are yoy'

        ];
        const resultBox=document.querySelector(".result-box");
        const inputBox=document.getElementById("Account-Box");
        inputBox.onkeyup=function(){
            let result=[];
            let input=inputBox.value;
            if(input.length){
                result = inputdata.filter((keyword)=>
                {
                  return  keyword.toLowerCase().includes(input.toLowerCase());
                })

                ;
                console.log(result);

            }
            display(result);
            if(!result.length){
                resultBox.innerHTML='';
            }
        }
        function display(result){
            const content = result.map((list)=>{
                return "<li onclick=selectedItem(this)>" + list + "</li>"
            });
            resultBox.innerHTML="<ul>" + content.join(' ') + "</ul>";
        }
        function selectedItem(list){
            inputBox.value=list.innerHTML;
            resultBox.innerHTML=' ';
        }