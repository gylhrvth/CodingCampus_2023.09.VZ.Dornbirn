<template>
    <h1>City</h1>
    <p v-for="item in data.results">Name: {{item.Name}} in {{item.Province}}</p>
</template>

<script>
import { usePageContext } from '../../renderer/usePageContext'

const pageProps = ['data']
export default { 
    props: pageProps,

    setup(props){
        console.log("setup()")
        const pageContext = usePageContext()
        const data = pageContext.data
    
        console.log("PS --> ", pageContext.data)

        return {data}
    }
}
</script>