<template>
  <v-row justify="center" align="center">
    <v-col cols="12" sm="8" md="6">
      <div class="text-center">
        <logo />
        <vuetify-logo />
      </div>
      <v-card>
        <v-card-title class="headline">
          {{ message }}
          <v-btn @click="reset" />
        </v-card-title>

        <div v-if="maneuvers">
          <p v-for="m in maneuvers" :key="m.id">
            {{ m.name }}
          </p>
        </div>

        <div>
          <v-text-field v-model="maneueverName" label="Maneuver Name" />
          <v-btn @click="saveManeuver">
            Save Maneuver
          </v-btn>
        </div>
      </v-card>
    </v-col>
  </v-row>
</template>

<script>
import { mapState, mapActions, mapMutations } from 'vuex'
import Logo from '~/components/Logo.vue'
import VuetifyLogo from '~/components/VuetifyLogo.vue'

export default {
  components: {
    Logo,
    VuetifyLogo
  },
  data: () => ({
    maneueverName: ''
  }),
  async fetch () {
    await this.$store.dispatch('fetchMessage')
  },
  computed: {
    ...mapState({
      message: state => state.message
    }),
    ...mapState('maneuvers', {
      maneuvers: state => state.maneuvers
    })
  },
  methods: {
    ...mapMutations([
      'reset'
    ]),
    ...mapMutations({
      resetTricks: 'reset'
    }),
    ...mapActions('maneuvers', ['createManeuver']),
    async saveManeuver () {
      await this.createManeuver({ maneuver: { name: this.maneueverName } })
      this.maneueverName = ''
    }
  }
}
</script>
